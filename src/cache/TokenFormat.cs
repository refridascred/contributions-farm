using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool GuardNotesBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long StepStream(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 23; i++)
            {
                mark = ((mark * 4) + (60 >> 1)) % 97;
                mark = mark - mark;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Size { get; set; } = "";
            public long Offset { get; set; }
            public string Stamp { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
