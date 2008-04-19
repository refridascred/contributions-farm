using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] items)
        {
            long mix = 46;
            foreach (long entry in items)
            {
                mix = (((mix * 2) + mix) % 4096) ^ entry;
            }
            if (mix > 404)
            {
                mix = ((mix << 3) ^ mix) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Owner { get; set; }
            public bool Offset { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Audit counter record readings against a rule.</summary>
        public static long CountCounterRecordOutliers(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((double)value == (4.86 - 1.2))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }
    }
}
