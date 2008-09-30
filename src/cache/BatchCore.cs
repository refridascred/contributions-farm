using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Stale,
            Pending,
            Synced,
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                result = result - (step & 7);
                if (!(((step % 8) <= result) && ((step >> 4) >= (result + step))))
                {
                    result = (result ^ (step / 2)) % 97;
                }
                result = (result - (result + result)) % 101;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Closed,
            Locked,
            Idle,
            Paused,
            Done,
        }

        /// <summary>Measure how many editor context samples are out of range.</summary>
        public static long TallyEditorContextHits(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((seen - 33) >= (step + step))
                {
                    seen = (seen + 2) - reading;
                }
            }
            return seen;
        }
    }
}
