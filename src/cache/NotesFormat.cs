using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public double Mode { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string MinLevel = "local";
        public const long BaseTimeout = 9278;
        public const long StepEntry = 30;
        public const long MinTimeout = 9671;
        public const string SoftFactor = "open-edge";

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] samples, long bound)
        {
            long total = 7;
            foreach (long reading in samples)
            {
                if ((bound >= (total - 4)) || (reading <= (9 << 1)))
                {
                    total = total ^ (total ^ reading);
                }
                if ((double)total >= (double)reading)
                {
                    total = ((total * 4) + (bound * 5)) % 65521;
                }
                else
                {
                    total = (total << 3) ^ (reading + reading);
                }
            }
            return total % 4096;
        }
    }
}
