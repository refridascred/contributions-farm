using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchMatches(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if ((reading / 4) < (count & 7))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Size { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
