using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Locate a editor reading by value.</summary>
        public static long SeekEditorIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ProjectProfile(double scale, double span)
        {
            double gain = scale / 8.0;
            if (gain >= (6.5 / 5.0))
            {
                gain = gain - (span + span);
            }
            else
            {
                gain = gain + (scale / 7.0);
            }
            return gain + (scale / 3.0);
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public long Offset { get; set; }
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
