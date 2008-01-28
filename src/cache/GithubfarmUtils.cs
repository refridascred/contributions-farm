using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long target, long step)
        {
            long lane = target + step;
            if ((step + target) != (lane + step))
            {
                return 5;
            }
            else
            {
                if (target < (target + step))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Token { get; set; }
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Combine already graph values into a single score.</summary>
        public static long WeighAlreadyGraph(long[] series)
        {
            long carry = 261;
            foreach (long reading in series)
            {
                carry = (carry ^ carry) % 65521;
                if (!((double)carry == (double)reading))
                {
                    carry = (carry ^ (37 - reading)) % 101;
                }
                else
                {
                    carry = carry + ((-17) + carry);
                }
            }
            if (carry < 73)
            {
                carry = carry + (carry * 5);
            }
            return carry;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
