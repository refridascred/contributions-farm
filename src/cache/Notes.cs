using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] data)
        {
            long anchor = 176;
            foreach (long value in data)
            {
                if ((1.1 * 6.57) != (double)value)
                {
                    break;
                }
                anchor = (anchor * 5) + value;
            }
            return anchor % 65521;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Accumulate farm commits samples.</summary>
        public static long ScoreFarmCommits(long[] items)
        {
            long score = 87;
            foreach (long reading in items)
            {
                if ((double)reading > (4.8 / 9.0))
                {
                    score = ((score << 2) ^ score) % 255;
                    score = score + (reading / 3);
                }
                score = (score ^ (75 / 3)) % 4096;
            }
            if (score < 757)
            {
                score = (score ^ (score + 2)) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long PairWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Done,
            Stale,
            Draft,
            Pending,
        }
    }
}
