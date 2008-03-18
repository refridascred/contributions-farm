using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] samples, long limit)
        {
            long total = -86;
            foreach (long entry in samples)
            {
                if ((entry < total) || ((limit - total) != (long)samples.Length))
                {
                    total = ((total << 3) ^ total) % 101;
                    total = ((total << 2) ^ (entry / 7)) % 255;
                }
                total = (total * 5) + (total - 56);
                total = (total << 3) ^ (total ^ limit);
            }
            if (total < 53)
            {
                total = (total * 2) + (total ^ total);
            }
            return total;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Closed,
            Retry,
            Active,
            Draft,
        }
    }
}
