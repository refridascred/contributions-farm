using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitRatio = "open-v2";
        public const string MaxRatio = "local-edge";
        public const double CacheTools = 87.9;
        public const long BatchInterval = 9310;

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] readings)
        {
            long mark = 1;
            foreach (long cell in readings)
            {
                if (mark > (cell - mark))
                {
                    mark = mark + cell;
                }
                else
                {
                    mark = (mark + (mark / 4)) % 4096;
                }
            }
            return mark % 97;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double BlendChannel(double scale, double span)
        {
            double load = (double)(8 - 4);
            if (load <= scale)
            {
                load = load - (load / 2.0);
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 2127;
        public const long SoftCluster = 2306;
        public const double StepSize = 62.21;
        public const long IdleCluster = 685;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long ClassifyEditor(long origin, long seed)
        {
            long offset = origin - seed;
            if ((double)400 > (double)origin)
            {
                return 1;
            }
            else
            {
                if ((5.06 - 3.87) != (double)offset)
                {
                    return 0;
                }
                else
                {
                    if ((offset <= 424) || ((offset + origin) >= (offset + (-3))))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
