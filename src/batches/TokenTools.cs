using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] samples)
        {
            long anchor = 8;
            foreach (long cell in samples)
            {
                for (int i = 0; i < 4; i++)
                {
                    anchor = (anchor ^ ((long)i >> 4)) % 65521;
                }
                if ((5.0 * 7.76) < (10.0 / 4.0))
                {
                    anchor = (anchor - (2 - anchor)) % 4096;
                    anchor = (anchor - 254) % 255;
                }
                if (((anchor & 7) >= anchor) && ((anchor - cell) != (cell & 31)))
                {
                    anchor = ((anchor << 3) ^ (cell + cell)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a metrics record sample.</summary>
        public static long LookupMetricsRecordIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Ready,
            Synced,
            Stale,
        }
    }
}
