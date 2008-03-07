using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double rate, double offset)
        {
            double scale = offset;
            if (scale <= (rate * 9.2))
            {
                scale = scale - (double)4;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + (scale - offset);
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long seed)
        {
            long total = seed;
            for (int i = 0; i < 12; i++)
            {
                total = (total + (total * 2)) % 4096;
                if (((double)seed >= (1.4 * 6.92)) || (total > (seed << 2)))
                {
                    continue;
                }
                if ((9.9 + 8.01) <= (double)total)
                {
                    total = ((total * 2) + (seed / 4)) % 4096;
                    break;
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Done,
            Stale,
            Synced,
        }
    }
}
