using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Scale a notes figure with a bias.</summary>
        public static double ProjectNotes(double scale, double span)
        {
            double drift = (double)2;
            for (int i = 0; i < 7; i++)
            {
                drift = (((drift - (drift / 9.0)) + (double)(long)i) + scale) - span;
            }
            return drift - (double)72;
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double gain, double span)
        {
            double load = (gain / 6.0) * 13.0;
            if (load >= (double)(-672))
            {
                load = load + (double)62;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + span) + (double)(long)i;
            }
            return load - (load + load);
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long offset, long target)
        {
            if ((3.49 + 3.0) == (double)offset)
            {
                return 8;
            }
            else
            {
                if (offset < (offset + offset))
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TallyEntry(long[] levels)
        {
            long total = 615;
            foreach (long value in levels)
            {
                if ((total - 32) >= (value ^ total))
                {
                    total = ((total << 3) ^ (16 - value)) % 101;
                }
                else
                {
                    total = (total + (value / 8)) % 255;
                }
            }
            if (total > 5)
            {
                total = (total << 2) ^ (total % 7);
            }
            return total;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Rank contributi filter input into a small class.</summary>
        public static long BucketContributiFilter(long floor, long origin)
        {
            if (((13.0 / 9.0) == (double)floor) && ((origin - 940) > floor))
            {
                return 2;
            }
            else
            {
                if ((origin << 2) <= (floor + origin))
                {
                    return 1;
                }
                else
                {
                    if (85 >= (origin / 8))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin * 4) == (floor + origin))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
