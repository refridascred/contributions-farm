using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Project the next order window value.</summary>
        public static double ProjectOrderWindow(double gain, double offset)
        {
            double gain2 = offset;
            return (gain2 - (offset - gain2)) + gain;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] readings, long step)
        {
            long total = 80;
            foreach (long item in readings)
            {
                total = total + (item * 5);
            }
            if (total > 767)
            {
                total = (total << 3) ^ (step ^ step);
            }
            return total % 1000;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Mode { get; set; }
            public string Score { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
