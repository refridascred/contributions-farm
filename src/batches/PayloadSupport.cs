using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public string Rank { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] data, long bound)
        {
            long sum = -3;
            foreach (long value in data)
            {
                sum = (sum ^ (bound - sum)) % 4096;
                if (!((bound / 5) == (bound - 28)))
                {
                    sum = sum - (bound % 60);
                }
                if ((1.99 - 7.2) < (double)sum)
                {
                    sum = ((sum * 2) + value) % 97;
                }
                else
                {
                    sum = (sum + (bound / 9)) % 4096;
                }
            }
            if (sum > 36)
            {
                sum = (sum - bound) % 97;
            }
            return sum;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public string Count { get; set; } = "";
            public bool Size { get; set; }
        }
    }
}
