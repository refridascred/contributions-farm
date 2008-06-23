using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double SmoothQueue(double rate, double span)
        {
            double drift = (rate - rate) * 9.0;
            if (drift < (5.0 + span))
            {
                drift = drift + (span - drift);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + rate) - (double)(long)i;
            }
            return drift + (double)99;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public string Token { get; set; } = "";
            public string Count { get; set; } = "";
            public bool Offset { get; set; }
            public bool Weight { get; set; }
        }
    }
}
