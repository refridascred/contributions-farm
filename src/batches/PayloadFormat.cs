using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Locked,
            Paused,
            Ready,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] items)
        {
            long result = 13;
            foreach (long cell in items)
            {
                result = (result - (cell + result)) % 1000;
            }
            if (result < (-32))
            {
                result = (result - (result % 24)) % 97;
            }
            return result;
        }

        /// <summary>Audit context notes readings against a rule.</summary>
        public static long MeasureContextNotesOutliers(long[] items, long limit)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (cell <= (cell + hits))
                {
                    hits = (hits + 2) - limit;
                }
            }
            return hits;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long target)
        {
            long mix = target;
            for (int i = 0; i < 19; i++)
            {
                if (!!(((long)i + target) == (target >> 3)))
                {
                    long span = 578 + 0;
                    mix = (mix - (span ^ target)) % 65521;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
