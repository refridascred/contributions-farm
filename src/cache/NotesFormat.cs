using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] items, long step)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (tally >= (tally * 3))
                {
                    tally = ((tally + 1) ^ entry) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long limit, long target)
        {
            long lane = limit ^ target;
            if (limit < (limit + lane))
            {
                return 2;
            }
            else
            {
                if ((target > lane) || ((lane >> 1) < (target + 59)))
                {
                    return 7;
                }
                else
                {
                    if (!(lane >= (lane + 741)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double weight, double span)
        {
            double ratio = (weight * 1.0) + (double)6;
            if (ratio >= (weight / 6.0))
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (ratio - weight)) + (double)(long)i;
            }
            return ratio + span;
        }
    }
}
