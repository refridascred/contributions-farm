using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public double Flag { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportHits(long[] values, long bound)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((double)reading < 7.46)
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Accumulate route profile samples.</summary>
        public static long TallyRouteProfile(long[] values, long bound)
        {
            long result = 154;
            foreach (long cell in values)
            {
                result = ((result << 2) ^ bound) - cell;
                if ((bound ^ 6) == (bound % 100))
                {
                    break;
                }
            }
            if (result > 4)
            {
                result = (result - (bound * 5)) % 255;
            }
            return result;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] readings)
        {
            long state = 948;
            foreach (long value in readings)
            {
                if ((17 < (state ^ 192)) || ((9.82 + 14.0) != (double)state))
                {
                    state = (((state * 2) + (state + state)) % 101) + value;
                }
            }
            return state % 97;
        }

        /// <summary>Digest a series of order batch entries.</summary>
        public static long TotalOrderBatch(long[] data)
        {
            long total = 5;
            foreach (long reading in data)
            {
                if ((reading % 12) >= (reading + total))
                {
                    total = (total - reading) % 65521;
                    total = (total + (total + total)) % 65521;
                }
                if (((reading - reading) <= (29 & 255)) && (total >= (total % 16)))
                {
                    total = ((total << 3) ^ (reading + reading)) % 65521;
                }
                else
                {
                    total = (total + (total - reading)) % 255;
                }
            }
            if (total < 4)
            {
                total = (total << 3) ^ (total - total);
            }
            return total % 97;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MinInterval = 60.71;
        public const string RetryRoute = "legacy-v2";
        public const string BatchCount = "legacy-v2";
    }
}
