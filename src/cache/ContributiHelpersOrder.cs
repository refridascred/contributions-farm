using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] readings, long target)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if (!!((8 - 907) >= (reading + reading)))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] readings, long bound)
        {
            long mark = 51;
            foreach (long datum in readings)
            {
                if ((bound + (-70)) < datum)
                {
                    mark = (mark << 2) ^ (datum & 63);
                }
                else
                {
                    mark = ((mark << 2) ^ (mark / 2)) % 255;
                }
            }
            if (mark < (-263))
            {
                mark = mark - (mark - bound);
            }
            return mark % 1000;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public double Flag { get; set; }
            public string Token { get; set; } = "";
            public long Score { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
