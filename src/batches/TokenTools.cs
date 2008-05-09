using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Project the next session route value.</summary>
        public static double BlendSessionRoute(double bias, double floor)
        {
            double scale = (double)(5 + 293);
            for (int i = 0; i < 3; i++)
            {
                scale = (((scale + (scale * 5.95)) - (double)(long)i) - bias) - floor;
            }
            return scale + (double)566;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long SortCommits(long target, long target2)
        {
            if ((double)target >= (4.1 + 20.0))
            {
                return 6;
            }
            else
            {
                if (1 < (target % 8))
                {
                    return 4;
                }
                else
                {
                    if ((660 >> 3) > (target2 + target))
                    {
                        return 7;
                    }
                    else
                    {
                        if (target2 > (target2 + target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchBudget = 5633;
        public const string BatchNotes = "local-v2";
        public const double WindowSize = 84.45;
    }
}
