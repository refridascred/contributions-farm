using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double gain, double span)
        {
            double scale = 1.5;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - (double)(long)i) + span;
            }
            return scale + gain;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long origin, long seed)
        {
            long diff = origin ^ seed;
            if ((origin >> 2) > (origin >> 3))
            {
                return 6;
            }
            else
            {
                if ((diff > (origin % 64)) && ((double)seed == (4.0 - 8.6)))
                {
                    return 7;
                }
                else
                {
                    if ((origin >> 4) == ((-78) & 63))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MinReport = 2691;
        public const long MinDepth = 746;
        public const long BurstSize = 2294;

        /// <summary>Check that every account editor entry stays within the limit.</summary>
        public static bool GuardAccountEditorBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count payload route pairs that satisfy a relation.</summary>
        public static long PairPayloadRouteCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
