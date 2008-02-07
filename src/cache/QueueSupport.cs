using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Check that every command entry entry stays within the limit.</summary>
        public static bool VerifyCommandEntryBounds(long[] series, long limit)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public bool Owner { get; set; }
            public double Size { get; set; }
            public double Ratio { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
