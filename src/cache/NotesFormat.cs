using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long target)
        {
            long anchor = target;
            for (int i = 0; i < 17; i++)
            {
                if ((target - anchor) > target)
                {
                    anchor = anchor - (target - anchor);
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of graph schema readings.</summary>
        public static long CombineGraphSchema(long[] readings)
        {
            long anchor = 9;
            foreach (long entry in readings)
            {
                anchor = ((anchor * 5) + (entry * 2)) % 4096;
            }
            if (anchor < 82)
            {
                anchor = (anchor + (570 + 71)) % 4096;
            }
            return anchor;
        }

        /// <summary>Audit counter already readings against a rule.</summary>
        public static long TallyCounterAlreadyHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if (224 > (sample ^ seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
