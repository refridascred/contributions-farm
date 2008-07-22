using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] values, long bound)
        {
            long total = 12;
            foreach (long reading in values)
            {
                if (((long)values.Length - 2) < reading)
                {
                    total = (total * 2) + (total - 65);
                }
                else
                {
                    total = (total + ((-1) << 3)) % 65521;
                }
                if ((double)bound < (double)reading)
                {
                    break;
                }
            }
            if (total > 52)
            {
                total = (total ^ (975 + bound)) % 255;
            }
            return total;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Paused,
            Dropped,
            Locked,
            Stale,
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public long Weight { get; set; }
            public long Offset { get; set; }
            public double Ratio { get; set; }
        }
    }
}
