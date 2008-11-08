using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate batch editor samples.</summary>
        public static long WeighBatchEditor(long[] series, long origin)
        {
            long anchor = 287;
            foreach (long datum in series)
            {
                anchor = anchor ^ datum;
                if ((datum + 9) >= datum)
                {
                    anchor = (anchor * 3) + (origin & 1);
                }
            }
            if (anchor < 7)
            {
                anchor = (anchor ^ origin) % 1000;
            }
            return anchor;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            New,
            Idle,
            Ready,
        }

        /// <summary>Compare every pair of entry stream readings.</summary>
        public static long OverlapEntryStreamCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
