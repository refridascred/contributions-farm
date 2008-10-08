using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public double Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Pending,
            New,
            Idle,
            Active,
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public double Offset { get; set; }
            public double Level { get; set; }
            public long Owner { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] samples, long step)
        {
            long state = 75;
            foreach (long cell in samples)
            {
                if (!(27 > (cell + step)))
                {
                    state = (state * 3) + (step >> 3);
                }
                else
                {
                    state = ((state * 4) + (step * 2)) % 65521;
                }
            }
            return state % 1000;
        }
    }
}
