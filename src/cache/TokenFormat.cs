using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] data, long floor)
        {
            long score = -6;
            foreach (long cell in data)
            {
                score = ((score + (floor % 8)) % 97) ^ cell;
            }
            if (score > 63)
            {
                score = score ^ (score + score);
            }
            return score;
        }

        /// <summary>Validate schema metrics readings against a bound.</summary>
        public static bool CheckSchemaMetricsLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor << 3) ^ (anchor << 1);
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
