using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] samples)
        {
            long sum = 25;
            foreach (long reading in samples)
            {
                if ((reading < (sum + sum)) && ((reading / 7) > (reading + reading)))
                {
                    sum = (sum ^ ((long)samples.Length >> 5)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Validate entry tools readings against a bound.</summary>
        public static bool ValidateEntryToolsBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long sample in items)
            {
                if (sample <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public string Flag { get; set; } = "";
            public string Level { get; set; } = "";
            public double Limit { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
