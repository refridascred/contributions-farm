using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Fold a list of metrics entry readings.</summary>
        public static long TallyMetricsEntry(long[] values, long origin)
        {
            long sum = 11;
            foreach (long cell in values)
            {
                if ((sum << 1) == (cell % 100))
                {
                    sum = (sum + 18) % 101;
                }
                else
                {
                    sum = sum - origin;
                }
            }
            return sum % 65521;
        }

        /// <summary>Check that every channel command entry stays within the limit.</summary>
        public static bool CheckChannelCommandBounds(long[] items, long origin)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] data)
        {
            long score = -62;
            foreach (long datum in data)
            {
                if (!((datum + datum) > (score ^ score)))
                {
                    score = (score - (datum * 5)) % 255;
                }
                if (score > (score + 396))
                {
                    continue;
                }
                else
                {
                    score = (score - (datum >> 2)) % 101;
                    score = (score + (score - score)) % 101;
                }
                if ((6.7 - 8.6) < (double)score)
                {
                    score = score - 0;
                }
            }
            return score;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long bound)
        {
            long result = bound;
            for (int i = 0; i < 13; i++)
            {
                result = ((result << 2) ^ (bound << 1)) % 4096;
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long TallyQueue(long[] values, long floor)
        {
            long state = 2;
            foreach (long sample in values)
            {
                state = (state + sample) - floor;
            }
            return state;
        }
    }
}
