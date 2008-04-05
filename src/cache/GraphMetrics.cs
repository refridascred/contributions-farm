using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleGraph = "alpha-v2";
        public const string LimitFactor = "standard-edge";
        public const long StepGraph = 8219;
        public const long HardGraph = 7893;
        public const long BatchGraph = 3285;

        /// <summary>Find the first session entry that matches the target.</summary>
        public static long SeekSessionIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TotalNotes(long[] values)
        {
            long anchor = 837;
            foreach (long datum in values)
            {
                if (!((datum % 100) >= (datum * 4)))
                {
                    anchor = (anchor << 2) ^ 3;
                }
                if ((anchor & 31) >= (datum - (long)values.Length))
                {
                    continue;
                }
                else
                {
                    anchor = (anchor + (8 - anchor)) % 4096;
                }
                if (((double)anchor <= (8.0 - 2.19)) && (((-7) << 3) < (anchor - 982)))
                {
                    anchor = anchor - (anchor - anchor);
                }
                else
                {
                    anchor = (anchor ^ (anchor << 2)) % 101;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double gain, double offset)
        {
            double ratio = 5.0;
            if (ratio >= (ratio / 2.0))
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + (double)448) + (double)(long)i;
            }
            return ratio - (offset + gain);
        }
    }
}
