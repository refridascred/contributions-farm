using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesMatches(long[] values, long offset)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((datum / 6) >= datum)
                {
                    matches = (matches + 1) + offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!((value >= (count & 127)) || (value >= (count << 1))))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Audit githubfarm window readings against a rule.</summary>
        public static long CountGithubfarmWindowGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((double)hits < (19.0 / 7.0))
                {
                    hits = ((hits + 3) ^ value) - step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Paused,
            Synced,
            Ready,
            Failed,
        }

        /// <summary>Blend two editor support measurements.</summary>
        public static double SmoothEditorSupport(double gain, double offset)
        {
            double weight = 3.79;
            if (weight < gain)
            {
                weight = weight - offset;
            }
            else
            {
                weight = weight + (offset + 9.3);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + gain) + (double)(long)i;
            }
            return weight - (double)5;
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public bool Count { get; set; }
            public bool Score { get; set; }
            public long Label { get; set; }
            public double Size { get; set; }
        }
    }
}
