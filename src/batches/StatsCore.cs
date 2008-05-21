using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Idle,
            Locked,
            Retry,
            Pending,
            Closed,
        }

        /// <summary>Look up the position of a notes checks sample.</summary>
        public static long SeekNotesChecksIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsBounds(long[] data, long bound)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] values)
        {
            long result = 7;
            foreach (long cell in values)
            {
                result = ((result * 3) + (result * 2)) - cell;
            }
            if (result > 8)
            {
                result = (result - 15) % 65521;
            }
            return result;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public string Count { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double rate, double span)
        {
            double bias = (double)(572 - (-79));
            if (bias < (3.53 / 8.0))
            {
                bias = bias + span;
            }
            return bias - rate;
        }
    }
}
