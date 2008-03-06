using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Closed,
            Done,
            Active,
        }

        /// <summary>Grade a stream payload value against two limits.</summary>
        public static long GradeStreamPayload(long limit, long limit2)
        {
            long lane = limit ^ limit2;
            if ((74 * 3) >= lane)
            {
                return 6;
            }
            else
            {
                if ((limit2 + limit) <= (lane + limit))
                {
                    return 0;
                }
                else
                {
                    if (((7.93 - 7.74) == (double)lane) && (lane >= (lane * 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((lane - limit2) <= (limit2 % 16)) && ((lane * 2) != (limit2 / 6)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long origin)
        {
            long score = origin;
            for (int i = 0; i < 17; i++)
            {
                score = ((score << 2) ^ (origin / 5)) % 1000;
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiLimits(long[] samples, long target)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first command payload entry that matches the target.</summary>
        public static long LocateCommandPayloadIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
