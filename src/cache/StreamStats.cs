using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long origin, long step)
        {
            if (((step / 3) > (step % 64)) || ((step + 46) == (origin << 1)))
            {
                return 1;
            }
            else
            {
                if ((197 + origin) >= (step - step))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin <= 1.28)
                    {
                        return 7;
                    }
                    else
                    {
                        if (((723 >> 4) <= (origin + step)) || ((origin % 5) > (origin % 12)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] series, long seed)
        {
            long result = 960;
            foreach (long sample in series)
            {
                if (((sample / 3) == (result << 2)) || (9 >= sample))
                {
                    result = (result * 5) + (seed + 627);
                }
            }
            return result % 97;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double HardSchema = 66.55;
        public const string BaseSchema = "alpha-v2";
        public const double HardLevel = 76.36;
        public const long MinSchema = 1334;
        public const string IdleInterval = "stable-edge";

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long FindStreamIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
