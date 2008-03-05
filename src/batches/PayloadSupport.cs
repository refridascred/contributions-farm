using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first batches editor entry that matches the target.</summary>
        public static long LookupBatchesEditorIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public double Owner { get; set; }
            public bool Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long step)
        {
            long total = step;
            for (int i = 0; i < 21; i++)
            {
                if ((step - 394) >= (step & 63))
                {
                    total = total - (step << 2);
                }
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }
    }
}
