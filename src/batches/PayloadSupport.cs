using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long OverlapFarmCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the order context series from a seed.</summary>
        public static long DeriveOrderContext(long floor)
        {
            long result = floor;
            for (int i = 0; i < 6; i++)
            {
                result = ((result * 3) + (result - (long)i)) % 65521;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Audit contributi token readings against a rule.</summary>
        public static long AuditContributiTokenOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample - seen) != (seen << 1))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }
    }
}
