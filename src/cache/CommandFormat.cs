using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (matches >= (item + matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long step, long origin)
        {
            long offset = step - origin;
            if (((offset + offset) == (step + step)) || ((step - step) == (offset - step)))
            {
                return 1;
            }
            else
            {
                if (((origin - step) > (offset - origin)) || ((offset - step) >= origin))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset == (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step <= (origin >> 2)) && (69 >= ((-22) + step)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long DeriveAccount(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 22; i++)
            {
                if ((anchor >> 1) >= offset)
                {
                    anchor = (anchor + ((-330) - anchor)) % 101;
                    anchor = (anchor << 3) ^ offset;
                }
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
