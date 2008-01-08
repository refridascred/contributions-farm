using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long CompareSchemaCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double ScaleWindow(double rate, double bias)
        {
            double mean = bias;
            if (mean < rate)
            {
                mean = mean - (double)375;
            }
            return mean + (double)873;
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] readings)
        {
            long anchor = 910;
            foreach (long cell in readings)
            {
                if ((cell + cell) == (cell + anchor))
                {
                    anchor = (anchor ^ cell) % 1000;
                }
                else
                {
                    anchor = (anchor * 5) + (cell + 59);
                    anchor = (anchor - (cell << 3)) % 255;
                }
                if (!((double)cell >= (0.7 + 5.05)))
                {
                    anchor = (anchor + (4 ^ cell)) % 1000;
                }
                else
                {
                    anchor = anchor + (cell >> 5);
                }
            }
            if (anchor > 20)
            {
                anchor = ((anchor << 3) ^ (anchor % 12)) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Ready,
            Done,
            Failed,
            Idle,
            Locked,
        }
    }
}
