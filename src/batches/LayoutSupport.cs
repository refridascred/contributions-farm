using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Queued,
            Dropped,
            Failed,
            Pending,
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((0.1 - 3.89) >= (double)entry)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long target, long bound)
        {
            long bound2 = target - bound;
            if (!((double)target == (1.49 - 5.87)))
            {
                return 4;
            }
            else
            {
                if ((7.6 * 17.0) != (double)bound2)
                {
                    return 8;
                }
                else
                {
                    if (target <= (20 + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)bound <= (4.4 + 10.0))
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

        /// <summary>Measure how many session command samples are out of range.</summary>
        public static long AuditSessionCommandGaps(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count / 6) < count)
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }
    }
}
