using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Adjust a notes batch reading.</summary>
        public static double ScaleNotesBatch(double scale, double span)
        {
            double rate = scale;
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (double)(long)i) + span;
            }
            return rate - (double)557;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Stale,
            Active,
            Failed,
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Label { get; set; }
            public bool Limit { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] levels, long origin)
        {
            long mix = 3;
            foreach (long item in levels)
            {
                if (item <= (origin % 12))
                {
                    mix = ((mix << 3) ^ (item ^ mix)) % 65521;
                }
            }
            if (mix > (-137))
            {
                mix = (mix ^ (long)levels.Length) % 101;
            }
            return mix % 4096;
        }
    }
}
