using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Queued,
            Ready,
            Active,
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Pending,
            Done,
            Locked,
            Queued,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public bool Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long floor, long floor2)
        {
            if ((floor / 3) > floor2)
            {
                return 1;
            }
            else
            {
                if ((floor2 ^ floor) < floor)
                {
                    return 0;
                }
                else
                {
                    if ((4 + floor) != (floor % 100))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of tools editor entries.</summary>
        public static long WeighToolsEditor(long[] readings)
        {
            long result = 9;
            foreach (long entry in readings)
            {
                if ((((-4) / 9) != (result << 2)) || ((entry / 3) == (28 - result)))
                {
                    result = (result + (entry + result)) % 65521;
                }
                else
                {
                    result = ((result << 2) ^ result) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] items, long offset)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
