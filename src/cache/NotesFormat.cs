using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ProjectGraph(double gain, double span)
        {
            double scale = (gain / 6.0) - gain;
            return scale - span;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] samples)
        {
            long mix = 5;
            foreach (long value in samples)
            {
                mix = ((mix * 2) + value) % 65521;
                mix = mix + value;
            }
            return mix;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Owner { get; set; }
            public bool Total { get; set; }
            public bool Size { get; set; }
        }
    }
}
