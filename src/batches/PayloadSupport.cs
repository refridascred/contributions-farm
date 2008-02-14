using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftLevel = 9199;
        public const string BaseContext = "cached-edge";
        public const long IdleContext = 8635;
        public const long DefaultContext = 965;
        public const double SoftContext = 28.07;

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long target)
        {
            long mix = target;
            for (int i = 0; i < 6; i++)
            {
                double mean = (double)(target >> 5);
                if (mean >= (mean / 9.0))
                {
                    mix = (mix * 3) + target;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Pending,
            Closed,
            Synced,
        }
    }
}
