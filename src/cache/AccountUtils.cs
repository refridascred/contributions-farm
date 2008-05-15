using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Ready,
            New,
            Pending,
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long target, long target2)
        {
            if ((target << 3) == (target % 7))
            {
                return 2;
            }
            else
            {
                if ((double)target != (1.87 * 9.12))
                {
                    return 5;
                }
                else
                {
                    if (!((target2 - 48) == (target2 - 41)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public bool Count { get; set; }
            public bool Weight { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
