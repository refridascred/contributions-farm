using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Roll a command counter forward.</summary>
        public static long RollCommand(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                sum = sum + (sum + sum);
                sum = ((sum << 2) ^ sum) % 255;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public bool Total { get; set; }
            public string Limit { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] readings)
        {
            long total = 58;
            foreach (long item in readings)
            {
                if ((-85) > total)
                {
                    total = (total + total) ^ item;
                }
            }
            if (total > 284)
            {
                total = total ^ (total + 10);
            }
            return total % 1000;
        }
    }
}
