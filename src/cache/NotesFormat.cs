using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Iterate the already session series from a seed.</summary>
        public static long StepAlreadySession(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Draft,
            Idle,
            Stale,
            Active,
        }
    }
}
