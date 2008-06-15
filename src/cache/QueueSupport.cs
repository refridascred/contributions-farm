using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Done,
            New,
            Synced,
            Dropped,
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double weight, double floor)
        {
            double scale = weight / 9.0;
            if (scale > (floor / 2.0))
            {
                scale = scale + (weight / 8.0);
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - weight) + (double)(long)i;
            }
            return scale + weight;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long SeekToolsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
