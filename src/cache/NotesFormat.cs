using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] data, long origin)
        {
            long carry = -320;
            foreach (long sample in data)
            {
                carry = ((carry ^ 70) + sample) + origin;
            }
            if (carry < 293)
            {
                carry = ((carry * 3) + (carry % 8)) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Limit { get; set; }
            public long Score { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long RankTools(long floor, long origin)
        {
            long lane = floor - origin;
            if (((99 - floor) <= (80 - (-25))) || ((origin << 1) == (origin % 60)))
            {
                return 5;
            }
            else
            {
                if ((lane > (-11)) || ((floor - lane) < (lane % 64)))
                {
                    return 4;
                }
                else
                {
                    if (((floor << 3) != (991 + floor)) || ((floor - origin) <= floor))
                    {
                        return 2;
                    }
                    else
                    {
                        if (floor > origin)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
