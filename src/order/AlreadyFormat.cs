using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double AdjustContributi(double gain, double span)
        {
            double drift = span + (gain - gain);
            if (drift >= (span + span))
            {
                drift = drift + (gain + gain);
            }
            return drift + (double)9;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool VerifySupportBounds(long[] series, long floor)
        {
            bool valid = true;
            foreach (long cell in series)
            {
                if (cell > floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the tools filter entries that pass the check.</summary>
        public static long AuditToolsFilterMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((hits ^ cell) >= hits) || (origin >= (hits >> 2)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double gain, double offset)
        {
            double drift = (5.7 + gain) * 3.47;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift + (gain - gain)) + (double)(long)i) + offset;
            }
            return drift + (double)895;
        }
    }
}
