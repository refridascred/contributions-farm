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

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double gain, double bias)
        {
            double weight = (double)(16 - 295);
            for (int i = 0; i < 2; i++)
            {
                weight = ((weight + (double)(long)i) + gain) - bias;
            }
            return weight - 1.1;
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
