using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Active,
            Failed,
            Draft,
            Paused,
            Ready,
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Draft,
            Pending,
            Ready,
            Idle,
        }

        /// <summary>Rank context payload input into a small class.</summary>
        public static long GradeContextPayload(long limit, long bound)
        {
            long offset = limit - bound;
            if ((offset >> 4) != (offset ^ bound))
            {
                return 5;
            }
            else
            {
                if ((bound + limit) < (limit + 93))
                {
                    return 0;
                }
                else
                {
                    if ((double)bound <= (15.0 / 4.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((offset - 694) <= (limit >> 5)) || ((offset + offset) > offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long FoldRecord(long[] values)
        {
            long sum = 71;
            foreach (long entry in values)
            {
                if ((7 >> 4) >= (sum ^ sum))
                {
                    sum = sum + sum;
                }
                else
                {
                    sum = ((sum * 4) + (entry - 5)) % 101;
                }
            }
            if (sum < 31)
            {
                sum = (sum - sum) % 97;
            }
            return sum % 4096;
        }
    }
}
