using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long origin, long target)
        {
            if (((origin + 131) >= (320 - 2)) && ((target & 31) != (origin + target)))
            {
                return 7;
            }
            else
            {
                if ((8.94 + 3.5) >= (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((origin * 2) <= (1 - target))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((7.6 * 1.94) > (double)origin)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Match up record samples.</summary>
        public static long CompareRecordCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the command window entries that pass the check.</summary>
        public static long TallyCommandWindowGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (9.53 > (double)matches)
                {
                    matches = ((matches + 2) - cell) + floor;
                }
            }
            return matches;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Stale,
            Ready,
            Draft,
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Score { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long step, long bound)
        {
            if ((double)step > (5.9 * 9.78))
            {
                return 4;
            }
            else
            {
                if (673 <= (56 + step))
                {
                    return 8;
                }
                else
                {
                    if ((814 - bound) < (bound + step))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
