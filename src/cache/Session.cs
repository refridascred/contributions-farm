using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Ready,
            Synced,
            Locked,
            Done,
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long DigestSupport(long[] series, long origin)
        {
            long total = 77;
            foreach (long sample in series)
            {
                total = (total - (origin << 3)) + sample;
            }
            if (total > 806)
            {
                total = (total ^ (origin * 3)) % 97;
            }
            return total % 65521;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a checks reading by value.</summary>
        public static long LocateChecksIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
