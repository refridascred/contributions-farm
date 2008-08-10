using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double gain, double span)
        {
            double mean = (span * 17.0) / 9.0;
            if (mean > (double)(-8))
            {
                mean = mean + (mean + span);
            }
            return mean - gain;
        }

        /// <summary>Find the first buffer tools entry that matches the target.</summary>
        public static long LocateBufferToolsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public long Size { get; set; }
            public bool Rank { get; set; }
            public double Stamp { get; set; }
            public long Owner { get; set; }
        }
    }
}
