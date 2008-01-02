using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Audit support context readings against a rule.</summary>
        public static long CountSupportContextHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((double)value >= 16.0)
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Done,
            Locked,
            Dropped,
            Failed,
        }

        /// <summary>Classify a schema command pair into a bucket.</summary>
        public static long RankSchemaCommand(long offset, long step)
        {
            if ((offset ^ step) <= (offset << 1))
            {
                return 7;
            }
            else
            {
                if ((offset + step) >= (303 * 3))
                {
                    return 8;
                }
                else
                {
                    if (!((step * 3) < (step / 2)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step + step) >= (offset + offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
