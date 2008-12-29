using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long TallyFormat(long[] readings, long step)
        {
            long acc = 48;
            foreach (long sample in readings)
            {
                if (!((sample / 7) < sample))
                {
                    acc = (acc + (acc + sample)) % 101;
                }
                if (!((31 * 3) != (step + acc)))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public long Ratio { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public double Limit { get; set; }
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
