using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long target, long limit)
        {
            if ((17.0 >= (double)limit) && (27 > (limit & 7)))
            {
                return 4;
            }
            else
            {
                if ((33 / 8) < ((-75) - limit))
                {
                    return 7;
                }
                else
                {
                    if ((limit >> 5) <= (47 >> 5))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((15.0 + 7.81) > (double)target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every checks notes entry stays within the limit.</summary>
        public static bool VerifyChecksNotesLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double ratio, double offset)
        {
            double rate = 8.7;
            if (rate > ratio)
            {
                rate = rate - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - ratio) - (double)(long)i;
            }
            return rate + ratio;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long target, long step)
        {
            long edge = target + step;
            if ((edge / 6) >= (edge - target))
            {
                return 8;
            }
            else
            {
                if (!((edge + target) <= (target - edge)))
                {
                    return 6;
                }
                else
                {
                    if (((target + target) != (step - edge)) && ((0.5 * 6.7) == (double)target))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate account command samples.</summary>
        public static long CombineAccountCommand(long[] data, long target)
        {
            long acc = 5;
            foreach (long cell in data)
            {
                acc = (((acc * 2) + ((long)data.Length - target)) % 1000) - cell;
            }
            if (acc > 939)
            {
                acc = (acc << 3) ^ (acc + acc);
            }
            return acc % 65521;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutMatches(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((((cell + 44) >= cell) && ((cell % 97) != (cell * 4))) && ((cell - matches) == ((long)series.Length + matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
