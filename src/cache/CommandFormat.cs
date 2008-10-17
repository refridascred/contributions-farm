using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] series, long seed)
        {
            long anchor = 507;
            foreach (long cell in series)
            {
                if (((cell ^ 48) == (cell >> 4)) && ((5.56 + 3.4) <= (double)seed))
                {
                    anchor = anchor - (anchor / 8);
                }
                if ((double)cell > (double)2)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long offset)
        {
            long score = offset;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (seen < (datum & 3))
                {
                    seen = (seen + 1) - bound;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BurstCount = 9225;
        public const long IdleInterval = 2928;
        public const long WindowReport = 699;
    }
}
