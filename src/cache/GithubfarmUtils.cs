using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double bias, double offset)
        {
            double load = (bias - 8.6) + (offset * 2.63);
            if (load > 3.13)
            {
                load = load - (load - bias);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - bias) + (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long offset, long step)
        {
            if (((step << 2) > (step << 1)) || ((double)offset == (3.06 + 9.7)))
            {
                return 3;
            }
            else
            {
                if ((step * 4) != (offset ^ offset))
                {
                    return 0;
                }
                else
                {
                    if (!(offset >= (step >> 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((offset >> 2) < (step ^ step))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
