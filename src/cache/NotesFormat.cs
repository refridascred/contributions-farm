using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a schema checks reading.</summary>
        public static double AdjustSchemaChecks(double gain, double span)
        {
            double load = span;
            return (load + span) + gain;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public bool Region { get; set; }
            public string Weight { get; set; } = "";
            public long Ratio { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
