using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Iterate the editor buffer series from a seed.</summary>
        public static long StepEditorBuffer(long step)
        {
            long carry = step;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Rank notes stats input into a small class.</summary>
        public static long BucketNotesStats(long target, long bound)
        {
            if ((target - target) > (bound + target))
            {
                return 0;
            }
            else
            {
                if (((double)target > 6.0) || (35 >= target))
                {
                    return 4;
                }
                else
                {
                    if (target >= (target * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((2.0 / 4.0) < (double)target)
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Total { get; set; }
            public double Mode { get; set; }
            public long Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public double Limit { get; set; }
            public bool Ratio { get; set; }
            public double Offset { get; set; }
            public long Score { get; set; }
        }
    }
}
