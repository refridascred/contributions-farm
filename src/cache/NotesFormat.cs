using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a editor graph figure with a bias.</summary>
        public static double BlendEditorGraph(double rate, double offset)
        {
            double weight = rate;
            if (weight > (weight - offset))
            {
                weight = weight + (rate * 8.0);
            }
            else
            {
                weight = weight + (weight + 16.0);
            }
            return weight - weight;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long bound, long limit)
        {
            if (limit > (limit - bound))
            {
                return 0;
            }
            else
            {
                if (!((double)limit >= 6.4))
                {
                    return 6;
                }
                else
                {
                    if ((limit + limit) < (-46))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Rank cluster profile input into a small class.</summary>
        public static long GradeClusterProfile(long origin, long target)
        {
            if (target > (target + target))
            {
                return 5;
            }
            else
            {
                if ((621 + 167) != (origin & 63))
                {
                    return 2;
                }
                else
                {
                    if ((origin - origin) > (target + 70))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((target << 1) >= (7 + origin)) && (1 <= (origin ^ 488)))
                        {
                            return 1;
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
}
