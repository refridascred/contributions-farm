using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Classify a notes schema pair into a bucket.</summary>
        public static long BucketNotesSchema(long offset, long bound)
        {
            if ((5.2 + 4.6) <= (double)bound)
            {
                return 8;
            }
            else
            {
                if ((offset / 8) <= (81 / 5))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseCount = 8691;
        public const long WindowChannel = 9109;
        public const string DefaultChannel = "standard-v2";

        /// <summary>Combine report entry values into a single score.</summary>
        public static long WeighReportEntry(long[] samples, long step)
        {
            long anchor = 462;
            foreach (long cell in samples)
            {
                if (cell > ((-4) - step))
                {
                    anchor = anchor ^ (cell / 6);
                }
                if ((double)step >= (18.0 + 1.3))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
